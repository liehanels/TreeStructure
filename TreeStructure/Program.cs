namespace TreeStructure;

internal class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        int option = 0;
        TreeNode root = new TreeNode("All issues");

        TreeNode network = new TreeNode("\nNetwork issues\n");
        TreeNode local = new TreeNode("1. Local\n");
        TreeNode internet = new TreeNode("2. Internet\n");

        TreeNode software = new TreeNode("\nSoftware issues\n");
        TreeNode install = new TreeNode("1. Installation\n");
        TreeNode bugs = new TreeNode("2. Bugs\n");
        TreeNode removal = new TreeNode("3. Removal\n");

        TreeNode hardware = new TreeNode("\nHardware issues\n");
        TreeNode faulty = new TreeNode("1. Faulty\n");
        TreeNode upgrade = new TreeNode("2. Upgrade\n");

        TreeNode enquiries = new TreeNode("\nEnquiries\n");
        TreeNode business = new TreeNode("1. Business\n");
        TreeNode personal = new TreeNode("2. Personal\n");

        root.Children.Add(network);
        network.Children.Add(local);
        network.Children.Add(internet);
        root.Children.Add(software);
        software.Children.Add(install);
        software.Children.Add(bugs);
        software.Children.Add(removal);
        root.Children.Add(hardware);
        hardware.Children.Add(faulty);
        hardware.Children.Add(upgrade);
        root.Children.Add(enquiries);
        enquiries.Children.Add(business);
        business.Children.Add(personal);
        while (exit == false)
        {
            switch (option)
            {
                case 1:
                    networkMenu();
                    int input = int.Parse("0" + Console.ReadLine());
                    TreeNode issue = new TreeNode(describeIssue());
                    switch (input)
                    {
                        case 1:
                            local.Children.Add(issue);
                            option = 0;
                            break;
                        case 2:
                            internet.Children.Add(issue);
                            option = 0;
                            break;
                        default:
                            Console.Clear();
                            option = 0;
                            break;
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    TraverseTree(root);
                    Console.ReadLine();
                    option = 0;
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    displayMenu();
                    option = int.Parse("0" + Console.ReadLine());
                    break;
            }
        }
    }
    private static void displayMenu()
    {
        Console.Clear();
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Network");
        Console.WriteLine("2. Software");
        Console.WriteLine("3. Hardware");
        Console.WriteLine("4. Enquiries");
        Console.WriteLine("5. View");
        Console.WriteLine("6. Exit");
    }
    private static void networkMenu()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Local Network");
        Console.WriteLine("2. Internet");
    }
    private static void softwareMenu()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Installation");
        Console.WriteLine("2. Removal");
        Console.WriteLine("3. Bugs");
    }
    private static void hardwareMenu()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Faulty");
        Console.WriteLine("2. Upgrade");
    }
    private static void enquiriesMenu()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Network");
        Console.WriteLine("2. Software");
        Console.WriteLine("3. Hardware");
        Console.WriteLine("4. General");
    }
    private static void generalEnquiriesMenu()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Business");
        Console.WriteLine("2. Personal");
    }
    private static string describeIssue()
    {
        Console.WriteLine("Describe your issue:");
        return "\t" + Console.ReadLine() + "\n";
    }
    public static void TraverseTree(TreeNode node)
    {
        if (node == null) { return; }
        Console.Write(node.Data + " ");
        foreach (var child in node.Children)
        {
            TraverseTree(child);
        }
    }
}
public class TreeNode
{
    public string Data {  get; set; }
    public List<TreeNode> Children { get; set; }
    public TreeNode(string  data)
    {
        this.Data = data;
        Children = new List<TreeNode>();
    }
}
