using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Windows;
using System.Diagnostics;
using ToDo.DataAccess.Models;
using ToDo.DataAccess;
using ToDo.DataAccess.Interfaces;

namespace ToDo.DataAccess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ItoDoAction _iToDoAction; 
        public ToDoController(ItoDoAction _iToDoAction)
        {
            this._iToDoAction = _iToDoAction;
        }

        [HttpGet]
        [Route("getAllToDo")]
        public async Task<ActionResult> GetAllToDo()
        {
            try
            {
                var toDoItems = _iToDoAction.SearchAll();
                return Ok(toDoItems);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("getToDo")]
        public async Task<ActionResult> GetToDo(string task)
        {
            try
            {

                var toDoItem = _iToDoAction.Search(task);
                return Ok(toDoItem);
            }
            catch (Exception ex)
            {
                return BadRequest(ex)
;            }
        }

        [HttpPost]
        [Route("addToDo")]
        public async Task<ActionResult<ToDoItem>> addToDo(ToDoItem request)
        {
            try
            {
                var toDoItems = _iToDoAction.Add(request);
                return Ok(toDoItems);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        [HttpPut]
        [Route("updateToDo")]
        public async Task<ActionResult> updateToDo(ToDoItem request, string category)
        {
            try
            {
                var toDoItems = _iToDoAction.Update(request,category);
                return Ok(toDoItems);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpDelete]
        [Route("deleteToDo")]
        public async Task<ActionResult> deleteToDo(string task)
        {
            try
            {
                var toDoItems = _iToDoAction.Delete(task);
                return Ok(toDoItems);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
