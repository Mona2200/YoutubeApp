// <copyright file="YoutubeReceiver.cs" company="Alyona">
// Copyright (c) 2022 All Rights Reserved
// </copyright>

namespace YoutubeApp
{
   using System.Threading.Tasks;
   using YoutubeExplode;
   using YoutubeExplode.Converter;
   using YoutubeExplode.Videos;

   public class YoutubeReceiver
   {
      protected YoutubeClient client;
      protected string Url;

      public YoutubeReceiver(string url)
      {
         client = new YoutubeClient();
         Url = url;
      }

      public async Task<Video> GetInfo()
      {
         var video = await client.Videos.GetAsync(Url);
         return video;
      }

      public async void Explode()
      {
         await client.Videos.DownloadAsync(Url, "video.mp4");
      }
   }
}
