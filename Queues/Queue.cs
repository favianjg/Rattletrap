using Discord;
using System;

namespace Rattletrap
{
  public enum QueueResult
  {
    Success,
    AlreadyQueuing,
  }

  public enum UnqueueResult
  {
    Success,
    NotQueuing
  }

  public abstract class IQueue
  {
    public String Name;
    public ITextChannel AnnouncementChannel;

    public IQueue(String InName, ITextChannel InAnnouncementChannel)
    {
      Name = InName;
      AnnouncementChannel = InAnnouncementChannel;
    }

    public abstract bool IsUserInQueue(IGuildUser InUser);
    public abstract QueueResult Queue(IGuildUser InUser, IGuildUser InTriggeringUser, IMessage InTriggeringMessage);
    public abstract UnqueueResult Unqueue(IGuildUser InUser, IGuildUser InTriggeringUser, IMessage InTriggeringMessage);
    public abstract string GetMatchInfo();
  }
}