
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Entities
{
   public interface IVideoData
   {
        IEnumerable<Video> GetAll();
        Video Get(int id);
        void Add(Video newVideo);
   }
}
