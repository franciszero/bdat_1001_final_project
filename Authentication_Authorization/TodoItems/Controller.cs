//using System;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using TodoApi.Models;

//namespace TodoApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TodoItemsController : ControllerBase
//    {
//        [HttpPost]
//        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
//        {
//            _context.TodoItems.Add(todoItem);
//            await _context.SaveChangesAsync();

//            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
//            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
//        }
//    }
//}

