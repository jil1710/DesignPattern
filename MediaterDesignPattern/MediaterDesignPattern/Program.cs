using MediaterDesignPattern.Interface;

namespace MediaterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatRoom();

            User user1 = new ChatUser("User1", chatMediator);
            User user2 = new ChatUser("User2", chatMediator);
            User user3 = new ChatUser("User3", chatMediator);

            chatMediator.JoinGroup(user1, "QWEfr45HJ");
            chatMediator.JoinGroup(user2, "QWEfr45HJ");
            chatMediator.JoinGroup(user3, "QWEfr45HJ");

            user1.SendMessage("Hello, everyone!");
            user2.SendMessage("Hi, User1!");
            user3.SendMessage("Hey there!");
        }
    }
}