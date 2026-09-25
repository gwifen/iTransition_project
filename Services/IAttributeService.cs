using project.Models;

namespace project.Services
{
	public interface IAttributeService
	{
		Task<List<SkillAttribute>> GetAllAsync();
		Task<List<SkillAttribute>> SearchAsync(string? prefix, int? categoryId, int take = 20);
		Task<SkillAttribute?> GetByIdAsync(int id);
		Task CreateAsync(SkillAttribute attribute);
		Task UpdateAsync(SkillAttribute attribute);
		Task DeleteAsync(int id);
		Task<List<AttributeCategory>> GetCategoriesAsync();
	}
}
