             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserclaimrepositoryrepositoryRepository : Repository<AspnetuserclaimrepositoryRepository>, IAspnetuserclaimrepositoryrepositoryRepository
	{

		public AspnetuserclaimrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserclaimrepositoryrepositoryRepository.cs file
	}
}
