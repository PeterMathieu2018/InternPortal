             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserconfigurationrepositoryrepositoryRepository : Repository<AspnetuserconfigurationrepositoryRepository>, IAspnetuserconfigurationrepositoryrepositoryRepository
	{

		public AspnetuserconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserconfigurationrepositoryrepositoryRepository.cs file
	}
}
