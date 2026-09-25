using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Models;

namespace project.Services
{
	public class AttributeService : IAttributeService
	{
		private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

		public AttributeService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
		{
			_dbContextFactory = dbContextFactory;
		}

		public async Task<List<SkillAttribute>> GetAllAsync()
		{
			using var context = await _dbContextFactory.CreateDbContextAsync();
			return await context.Attributes
				.AsNoTracking()
				.Include(a => a.Category)
				.Include(a => a.Options)
				.ToListAsync();
		}

		public async Task<List<SkillAttribute>> SearchAsync(string? prefix, int? categoryId = null, int take = 20)
		{
			using var context = await _dbContextFactory.CreateDbContextAsync();
			var query = context.Attributes
				.AsNoTracking()
				.Include(a => a.Category)
				.Include(a => a.Options)
				.AsQueryable();
			if (!string.IsNullOrWhiteSpace(prefix))
			{
				query = query.Where(a => a.Name.StartsWith(prefix));
			}
			if(categoryId.HasValue && categoryId > 0)
			{
				query = query.Where(a => a.CategoryId == categoryId);
			}
			return await query.OrderBy(a => a.Name).Take(take).ToListAsync();
		}

		public async Task<SkillAttribute?> GetByIdAsync(int id)
		{
			using var context = await _dbContextFactory.CreateDbContextAsync();
			return await context.Attributes
				.AsNoTracking()
				.Include(a => a.Category)
				.Include(a => a.Options)
				.FirstOrDefaultAsync(a => a.Id == id);
		}

		public async Task CreateAsync(SkillAttribute attribute)
		{
			using var context = await _dbContextFactory.CreateDbContextAsync();
			context.Attributes.Add(attribute);
			await context.SaveChangesAsync();
		}

		public async Task UpdateAsync(SkillAttribute attribute)
		{
			using var context = await _dbContextFactory.CreateDbContextAsync();
			var existing = await context.Attributes
				.Include(a => a.Options)
				.FirstOrDefaultAsync(a => a.Id == attribute.Id);

			if (existing is null) return;

			context.Entry(existing).CurrentValues.SetValues(attribute);
			if(attribute.Type == AttributeType.Select)
			{
				context.AttributeOptions.RemoveRange(existing.Options);
				existing.Options = attribute.Options;
			}
			await context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			using var context = await _dbContextFactory.CreateDbContextAsync();
			context.Remove(new SkillAttribute { Id = id });
			await context.SaveChangesAsync();
		}

		public async Task<List<AttributeCategory>> GetCategoriesAsync()
		{
			using var context = await _dbContextFactory.CreateDbContextAsync();
			return await context.AttributeCategories
				.AsNoTracking()
				.OrderBy(c => c.Name)
				.ToListAsync();
		}
	}
}
