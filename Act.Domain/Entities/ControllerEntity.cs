using System.Security.AccessControl;
using Act.Domain.ValueObjects;

namespace Act.Domain.Entities
{
    public class ControllerEntity : ComponentEntity
    {
        public ControllerEntity(Model model):base(model, ComponentEntity.CategoryType.Controller) { }
    }
}
