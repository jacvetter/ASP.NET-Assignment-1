using Assignment_1.Endpoints;

namespace Assignment_1;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
        
		//stuff for swagger
		builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

		//makes swagger work
		app.UseSwagger();
		app.UseSwaggerUI();

		//does the endpointing thingy
		app.MapProductEndpoints();

		app.Run();
	}
}
