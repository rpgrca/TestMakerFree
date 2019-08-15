using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestMakerFree.ViewModels;
using System.Collections.Generic;

namespace TestMakerFree.Controllers {
    [Route("api/[controller]")]
    public class QuestionController : Controller {
        #region RESTful conventions method
        /// <summary>
        /// GET: api/question/{}id
        /// Retrieves the Question with the given {id}
        /// </summary>
        /// <param name="id">The ID of an existing Question</param>
        /// <returns>the Question with the given {id}</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new Question to the Database
        /// </summary>
        /// <param name="m">The QuestionViewModel containing the data to insert</param>
        [HttpPut]
        public IActionResult Put(QuestionViewModel m) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Edit the Question with the given {id}
        /// </summary>
        /// <param name="m">The QuestionViewModel containing the data to update</param>
        [HttpPost]
        public IActionResult Post(QuestionViewModel m) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the Question with the given {id} from the Database
        /// </summary>
        /// <param name="id">The ID of an existing Question</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            throw new NotImplementedException();
        }
        #endregion

        /// <summary>
        /// GET api/question/all
        /// Retrieves the {num} latest Questions
        /// </summary>
        /// <param name="num">the number of questions to retrieve</param>
        /// <returns>the {num} latest Questions</returns>
        [HttpGet("All/{quizId}")]
        public IActionResult All(int quizId) {
            var sampleQuestions = new List<QuestionViewModel>();
            // add a first sample question
            sampleQuestions.Add(new QuestionViewModel() {
                Id = 1,
                QuizId = quizId,
                Text = "What do you value most in your life?",
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now
            });
            // add a bunch of other sample questions
            for (int i = 2; i <= 5; i++) {
                sampleQuestions.Add(new QuestionViewModel() {
                    Id = i,
                    QuizId = quizId,
                    Text = String.Format("Sample Question {0}", i),
                    CreatedDate = DateTime.Now,
                    LastModified = DateTime.Now
                });
            }
            // output the result in JSON format
            return new JsonResult(
                sampleQuestions,
                new JsonSerializerSettings() {
                    Formatting = Formatting.Indented
                }
            );
        }
    }
}