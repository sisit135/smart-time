// @author: SN
// @time 2/11/2022
// Auth token generator for Smart Time
using System.Security.Cryptography;
using System.Text;
using SmartTime.Core;

Console.WriteLine("Auth token generator for Smart Time.");
Console.WriteLine("Generated token also need to be registered in the server in order to work.");
Console.WriteLine("Do you want to save generated token to file? <Y/N> / คุณต้องการบันทึก Token ที่สร้างขึ้นมาหรือไม่? <Y/N>");
var shouldSaveTokens = (Console.ReadKey().Key == ConsoleKey.Y);
var tokenCount = 12;
var fileSizeLimit = 10 * 1024 * 1024;

// 4 Bytes fixed length. do not change.
byte[] tokenRndData = new byte[4];
var spanTokenRndData = new Span<byte>(tokenRndData);

Console.WriteLine("Generating token, This might take few seconds.");
using var stream = File.Open("generated.txt", FileMode.OpenOrCreate, FileAccess.Write);
using var writer = new StreamWriter(stream);
writer.WriteLine($"====== Tokens {DateTime.Now} ======");

for (int i = 0; i < tokenCount; i++)
{
    RandomNumberGenerator.Fill(spanTokenRndData);
    Console.Write(Environment.NewLine);
    if (shouldSaveTokens)
        writer.Write(Environment.NewLine);
    // foreach (var value in spanTokenRndData)
    // {
    //
    // }

    // TODO: impractical array allocation.
    var authToken = new AuthToken(spanTokenRndData.ToArray(), null);
    Console.Write(authToken.ToString());
    //Console.Write(Encoding.UTF8.GetString(spanTokenRndData));
    if (shouldSaveTokens)
        writer.Write(authToken.ToString());
}