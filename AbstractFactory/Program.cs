public class Program
{
    public static void Main()
    {
        var navigationApple = new NavigationBar(new Apple());
        var dropDownApple = new DropDownMenu(new Apple());

        Console.WriteLine(@$"It is a {navigationApple.GetType().Name}");
        Console.WriteLine(@$"It is a {dropDownApple.GetType().Name}");

        var navigationAndroid = new NavigationBar(new Android());
        var dropdownAndroid = new DropDownMenu(new Android());
        Console.WriteLine(@$"/r");
        Console.WriteLine(@$"It is a {navigationAndroid.GetType().Name}");
        Console.WriteLine(@$"It is a {dropdownAndroid.GetType().Name}");
    }

    public class NavigationBar
    {
        public NavigationBar(UIFactory factory) => factory.CreateButton();
    }

    public class DropDownMenu
    {
        public DropDownMenu(UIFactory factory) => factory.CreateButton();
    }

    public interface UIFactory
    {
        Button CreateButton();
    }

    public class Apple : UIFactory
    {
        public Button CreateButton()
        {
            return new Button { Type = "iOS Button" };
        }
    }

    public class Android : UIFactory
    {
        public Button CreateButton()
        {
            return new Button { Type = "Android Button" };
        }
    }

    public class Button{
        public string Type { get; set; }
        public Button()
        {
            
        }
    }
}