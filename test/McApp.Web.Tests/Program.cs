using Microsoft.AspNetCore.Builder;
using McApp;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<McAppWebTestModule>();

public partial class Program
{
}
