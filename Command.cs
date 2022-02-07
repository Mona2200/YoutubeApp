// <copyright file="Command.cs" company="Alyona">
// Copyright (c) 2022 All Rights Reserved
// </copyright>

namespace YoutubeApp
{
   public abstract class Command
   {
      public abstract void Run();
      public abstract void Cancel();
   }
}
