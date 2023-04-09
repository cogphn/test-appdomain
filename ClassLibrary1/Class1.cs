using System;

public sealed class Diagnostics : AppDomainManager {
    public override void InitializeNewDomain(AppDomainSetup appDomainInfo) {
        Console.WriteLine("test1");
        bool result = EvilClass.Run();
        return;
    }
}


public class EvilClass {
    public static bool Run() {
        Console.WriteLine("EVIL HAX!!");
        return true;
    }
}
