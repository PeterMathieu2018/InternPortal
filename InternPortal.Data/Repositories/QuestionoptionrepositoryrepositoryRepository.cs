             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionoptionrepositoryrepositoryRepository : Repository<QuestionoptionrepositoryRepository>, IQuestionoptionrepositoryrepositoryRepository
	{

		public QuestionoptionrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionoptionrepositoryrepositoryRepository.cs file
	}
}
