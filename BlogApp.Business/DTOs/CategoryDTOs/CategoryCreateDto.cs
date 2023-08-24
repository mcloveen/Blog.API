using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace BlogApp.Business.DTOs.CategoryDTOs
{
	public record CategoryCreateDto
	{
		public string ?Name { get; set; }
		public IFormFile ?Logo { get; set; }
	}
	public class CategoryCreateDtoValidator : AbstractValidator<CategoryCreateDto>
	{
		public CategoryCreateDtoValidator()
		{
			RuleFor(c => c.Name)
				.NotNull().WithMessage("Category name not be null")
				.NotEmpty().WithMessage("Category name not be empty")
				.MaximumLength(64).WithMessage("Category name not be longer than 64.");
			RuleFor(c => c.Logo)
				.NotNull().WithMessage("Category image not be null")
				.NotEmpty().WithMessage("Category image not be empty");
		}
	}
}
