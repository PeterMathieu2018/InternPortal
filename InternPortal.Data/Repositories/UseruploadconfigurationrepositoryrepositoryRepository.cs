             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UseruploadconfigurationrepositoryrepositoryRepository : Repository<UseruploadconfigurationrepositoryRepository>, IUseruploadconfigurationrepositoryrepositoryRepository
	{

		public UseruploadconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUseruploadconfigurationrepositoryrepositoryRepository.cs file
	}
}
