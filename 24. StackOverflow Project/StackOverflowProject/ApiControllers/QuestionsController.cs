using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StackOverflowProject.ServiceLayer;

namespace StackOverflowProject.ApiControllers
{
    public class QuestionsController : ApiController
    {
        IAnswersService asr;

        public QuestionsController(IAnswersService asr)
        {
            this.asr = asr;
        }

        public void Post(int AnswerID, int UserID, int value)
        {
            this.asr.UpdateAnswerVotesCount(AnswerID, UserID, value);
        }
    }
}



