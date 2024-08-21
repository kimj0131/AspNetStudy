namespace HelloEmpty
{
    // M (Model)        ������ (������)
    // V (View)         UI (���׸���)
    // C (Conntroller)  ���� ���� (�׼�)

    // M
    // VC 
    // M - V - VM

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // MVC ���񽺸� �߰��ؾ� Ȱ�밡��
            //builder.Services.AddMvc();

            // RazorPages ���񽺸� �߰�
            builder.Services.AddRazorPages();

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

            // RazorPage���
            app.MapRazorPages();

            app.Run();


        }
    }
}

