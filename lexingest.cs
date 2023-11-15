using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.KernelMemory;

namespace lexfunctionspace
{
    public class lexingest
    {
        [FunctionName("lexingest")]
        public async Task Run([BlobTrigger("output-files/{name}", Connection = "lexstorageacc_STORAGE")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
            var memory = new MemoryWebClient("https://legallex.azurewebsites.net");
            await memory.ImportDocumentAsync(myBlob);
        }
    }
}
