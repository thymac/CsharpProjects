Console.WriteLine("Enter permission: Admin|Manager");
string? permission = Console.ReadLine();

Console.WriteLine("Enter level: 0-100");
string? levelEntry = Console.ReadLine();

while (permission != null)
{
    if (!string.IsNullOrEmpty(permission) && !string.IsNullOrEmpty(levelEntry) && (permission.Equals("Admin", StringComparison.OrdinalIgnoreCase) || permission.Equals("Manager", StringComparison.OrdinalIgnoreCase)))
    {
        if (int.TryParse(levelEntry, out int level) && level < 100)
        {
            Console.WriteLine(permission.ToLower() switch
            {
                var p when p.Contains("admin") && level >= 55 => "Welcome, Super Admin user.",
                var p when p.Contains("admin") && level < 55 => "Welcome, Admin user.",
                var p when p.Contains("manager") && level >= 20 => "Contact an Admin for access.",
                var p when p.Contains("manager") && level < 20 => "You do not have sufficient privileges.",
                _ => ""
            });
            break;
        }
        else
        {
            Console.WriteLine("Enter a correct level entry (1-100)");
            levelEntry = Console.ReadLine() ?? "0";
            permission = permission;
        }
    }
    else
    {
        Console.WriteLine("Enter a correct permission entry Admin|Manager");
        permission = Console.ReadLine();
        levelEntry = levelEntry;
    }
}
