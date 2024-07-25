using System.Diagnostics;

class Program
{
	static void Main(string[] args)
	{
		string pastaParaApagar = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"AppData\Local\Packages\TheBrowserCompany.Arc_ttt1ap7aakyb4\LocalCache\Local\firestore\Arc");
		string caminhoExecutavel = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"AppData\Local\Microsoft\WindowsApps\Arc.exe");

		try
		{
			if (Directory.Exists(pastaParaApagar))
			{
				Directory.Delete(pastaParaApagar, true);
				Console.WriteLine("Pasta apagada com sucesso.");
			}
			else
			{
				Console.WriteLine("A pasta não existe.");
			}

			if (File.Exists(caminhoExecutavel))
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = caminhoExecutavel,
					UseShellExecute = true
				};
				Process.Start(startInfo);
				Console.WriteLine("Executável iniciado com sucesso.");
			}
			else
			{
				Console.WriteLine($"O executável não foi encontrado no caminho especificado: {caminhoExecutavel}");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Ocorreu um erro: {ex.Message}");
		}
	}
}