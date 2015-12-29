using System.Web.ModelBinding;

namespace Livro_ProfessionalAsp.NetMVC5_.Models
{

    public class PointModelBinder : System.Web.ModelBinding.IModelBinder
    {
        public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext)
        {
            //var valueProvider = bindingContext.ValueProvider;
            //int x = (int)valueProvider.GetValue("X").ConvertTo(typeof(int));
            //int y = (int)valueProvider.GetValue("Y").ConvertTo(typeof(int));
            //if (!bindingContext.FallbackToEmptyPrefix)
            //    return false;
            //bindingContext = new ModelBindingContext
            //{
            //    ModelMetadata = bindingContext.ModelMetadata,
            //    ModelState = bindingContext.ModelState,
              

            //    ValueProvider = bindingContext.ValueProvider
            //};
            return true;
        }

    }
    
}