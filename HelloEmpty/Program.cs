namespace HelloEmpty
{
    // M (Model)        데이터 (원자재)
    // V (View)         UI (인테리어)
    // C (Conntroller)  동작 제어 (액션)

    // M
    // VC 
    // M - V - VM

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // MVC 서비스를 추가해야 활용가능
            //builder.Services.AddMvc();

            // RazorPages 서비스를 추가
            builder.Services.AddRazorPages();

            var app = builder.Build();

            #region 레거시
            //// C# 11.0 버전의 원시 문자열 이터럴 (Raw string literals)
            //string htmlTag = """
            //<html lang="ko">
            //<body>
            //    <h1>Hello ASP.NET Core 8.0</h1>
            //</body>
            //</html>
            //""";

            //app.MapGet("/html-content-rendering", () => Results.Content(htmlTag, "text/html"));

            #endregion

            // 정적 HTML문서를 실행 (미들웨어 추가)
            app.UseStaticFiles();

            app.UseRouting();

            #region MVC 기반
            // MVC 기반
            //app.MapDefaultControllerRoute();
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");
            #endregion

            // RazorPage기반
            app.MapRazorPages();

            app.Run();


        }
    }
}

