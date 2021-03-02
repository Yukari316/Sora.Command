using System.Threading.Tasks;
using Sora.Command.Attribute;
using Sora.Command.Enumeration;
using Sora.Enumeration.EventParamsType;
using Sora.EventArgs.SoraEvent;

namespace CommandTest
{
    [CommandGroup("wow")]
    public class Commands
    {
        [GroupCommand("好耶", MemberRoleType.Member, MatchType.Full)]
        public async ValueTask TestCommand(GroupMessageEventArgs eventArgs)
        {
            await eventArgs.Reply("好耶");
        }
    }
}
