namespace tst.Translators
{
    using Boilerplate;
    using tst.ViewModels;

    public class CarToCarTranslator : ITranslator<Models.Car, Car>
    {
        public void Translate(Models.Car source, Car destination)
        {
            destination.CarId = source.CarId;
            destination.Cylinders = source.Cylinders;
            destination.Make = source.Make;
            destination.Model = source.Model;
        }
    }
}
