using GittiGidiyor.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyor.Services
{
    public class CommentSqlDatabase
    {
        readonly SQLiteAsyncConnection database;

        public CommentSqlDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Comment>().Wait();
        }
        public Task<List<Comment>> GetCommentsAsync()
        {
            //Get all Comments.
            return database.Table<Comment>().ToListAsync();
        }

        public Task<Comment> GetCommentAsync(string id)
        {
            // Get a specific Comment.
            return database.Table<Comment>()
                            .Where(i => i.ProductId == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveCommentAsync(Comment comment)
        {
            if (comment.ProductId != null)
            {
                // Update an existing Comment.
                return database.UpdateAsync(comment);
            }
            else
            {
                // Save a new Comment.
                return database.InsertAsync(comment);
            }
        }

        public Task<int> DeleteCommentAsync(Comment comment)
        {
            // Delete a Comment.
            return database.DeleteAsync(comment);
        }
    }
}
