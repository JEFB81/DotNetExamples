namespace ExerciesIntermediateClassesInterfaces.Composition
{
    public class ProcessComposition
    {
        public static void Run()
        {
            var dbMigrator = new DbMigrator(new Logger());
            dbMigrator.Migrate();
            // andere manier

            var logger = new Logger();
            var installer = new Installer(logger);
            installer.Install();
        }
    }
}
