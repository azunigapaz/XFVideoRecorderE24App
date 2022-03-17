using System;
using System.Collections.Generic;
using System.Text;
using XFVideoRecorderE24App.Models;
using System.Threading.Tasks;
using SQLite;

namespace XFVideoRecorderE24App.Controllers
{
    public class VideoDBController
    {

        readonly SQLiteAsyncConnection db;

        public VideoDBController(string pathdb)
        {
            db = new SQLiteAsyncConnection(pathdb);
            db.CreateTableAsync<VideoModel>().Wait();
        }

        public Task<List<VideoModel>> GetVideoList()
        {
            return db.Table<VideoModel>().ToListAsync();
        }

        public Task<VideoModel> GetVideoForId(int pcodigo)
        {
            return db.Table<VideoModel>()
                .Where(i => i.VideoId == pcodigo)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveVideoRecord(VideoModel videos)
        {
            if (videos.VideoId != 0)
            {
                return db.UpdateAsync(videos);
            }
            else
            {
                return db.InsertAsync(videos);
            }
        }

        public Task<int> DeleteVideo(VideoModel videos)
        {
            return db.DeleteAsync(videos);
        }

    }
}
