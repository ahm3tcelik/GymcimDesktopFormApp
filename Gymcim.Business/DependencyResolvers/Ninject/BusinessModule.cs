using Gymcim.Business.Abstract;
using Gymcim.Business.Concrete;
using Gymcim.DataAccess.Abstract;
using Gymcim.DataAccess.Concrete.EntityFramework;
using Gymcim.Entities.Concrete;
using Ninject.Modules;

namespace Gymcim.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();
            Bind<IExerciseService>().To<ExerciseManager>().InSingletonScope();
            Bind<IExerciseDal>().To<EfExerciseDal>().InSingletonScope();
            Bind<IPartService>().To<PartManager>().InSingletonScope();
            Bind<IPartDal>().To<EfPartDal>().InSingletonScope();
            Bind<IScheduleService>().To<ScheduleManager>().InSingletonScope();
            Bind<IScheduleDal>().To<EfScheduleDal>().InSingletonScope();
            Bind<IStatisticService>().To<StatisticManager>().InSingletonScope();
            Bind<IStatisticDal>().To<EfStatisticDal>().InSingletonScope();
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            Bind<ILogDal>().To<EfLogDal>().InSingletonScope();
        }
    }
}
