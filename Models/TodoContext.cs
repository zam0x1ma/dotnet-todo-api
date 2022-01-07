using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace dotnet_todo_api.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}
