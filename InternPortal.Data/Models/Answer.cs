// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace InternPortal.Data.Models
{

    // Answers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class Answer
    {
        public int AnswerId { get; set; } // AnswerId (Primary key)
        public int ApplicationId { get; set; } // ApplicationId
        public int QuestionId { get; set; } // QuestionId
        public int? OptionId { get; set; } // OptionId
        public string AnswerValue { get; set; } // AnswerValue

        // Foreign keys

        /// <summary>
        /// Parent Application pointed by [Answers].([ApplicationId]) (FK_dbo.Answers_dbo.Application_ApplicationId)
        /// </summary>
        public virtual Application Application { get; set; } // FK_dbo.Answers_dbo.Application_ApplicationId

        /// <summary>
        /// Parent Question pointed by [Answers].([QuestionId]) (FK_dbo.Answers_dbo.Question_QuestionId)
        /// </summary>
        public virtual Question Question { get; set; } // FK_dbo.Answers_dbo.Question_QuestionId

        /// <summary>
        /// Parent QuestionOption pointed by [Answers].([OptionId]) (FK_Answers_QuestionOptions)
        /// </summary>
        public virtual QuestionOption QuestionOption { get; set; } // FK_Answers_QuestionOptions

        public Answer()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
