using Act.Domain.ValueObjects;

namespace Act.Domain.Entities
{
    public abstract class ComponentEntity
    {
        public enum CategoryType
        {
            Controller = 1,
            Camera = 2,
        }

        public ComponentEntity(Model model, CategoryType category)
        {
            Model = model;
            Category = category;
        }
        public Model Model { get; }
        public CategoryType Category { get; }

    }
}

