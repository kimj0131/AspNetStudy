namespace HelloEmpty
{
    // MVC
    // M (Model)        ������ (������)
    // V (View)         UI (���׸���)
    // C (Conntroller)  ���� ���� (�׼�)

    // Razor
    // M
    // VC 
    // >> M - V - VM

    // WebAPI
    // M
    // C

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // MVC ���񽺸� �߰��ؾ� Ȱ�밡��
            //builder.Services.AddMvc();

            // RazorPages ���񽺸� �߰�
            //builder.Services.AddRazorPages();

            // WpeAPI���� �߰�
            builder.Services.AddControllers();

            var app = builder.Build();

            #region ���Ž�
            //// C# 11.0 ������ ���� ���ڿ� ���ͷ� (Raw string literals)
            //string htmlTag = """
            //<html lang="ko">
            //<body>
            //    <h1>Hello ASP.NET Core 8.0</h1>
            //</body>
            //</html>
            //""";

            //app.MapGet("/html-content-rendering", () => Results.Content(htmlTag, "text/html"));

            #endregion

            // ���� HTML������ ���� (�̵���� �߰�)
            app.UseStaticFiles();

            app.UseRouting();

            #region MVC ���
            // MVC ���
            //app.MapDefaultControllerRoute();
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");
            #endregion

            #region RazorPage ���
            // RazorPage���
            // app.MapRazorPages();
            #endregion

            // WebAPI
            app.MapControllers();

            app.Run();

        }
    }
}

