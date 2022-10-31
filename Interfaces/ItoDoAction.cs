using ToDo.DataAccess.Models;

namespace ToDo.DataAccess.Interfaces;

    public interface ItoDoAction
    {
        List<ToDoItem> Add(ToDoItem toDoItem);
        List<ToDoItem> Update(ToDoItem toDoItem,string category);
        ToDoItem Search(string task);
        List<ToDoItem> SearchAll();
        List<ToDoItem> Delete(string task);
    }

