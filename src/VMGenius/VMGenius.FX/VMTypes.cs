using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using VMGenius.Types;




namespace VMGenius.FX;
public static class VMTypes
{




    [FunctionName("GetVMTypes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "req even when not used is required for the FX runtime to work")]
    public static IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
    {




        //Downloading VM Types JSON
        //===========================

        var vmTypesURL = Environment.GetEnvironmentVariable("VMTypesURL");
        
        //>>  Parameter not found
        if (vmTypesURL == null)
            return new ConflictObjectResult(E.CONFIGURATION_PARAMETER_NOT_FOUND);


        HttpClient wc = new();
        string vmTypesJson;
        try
        {
            vmTypesJson = wc.GetStringAsync(vmTypesURL).Result;
        }
        catch
        {
            //>> Origin of data not found
            return new NotFoundObjectResult(E.INVALID_VMTYPES_SOURCE);
        }
        
       



        //Deserializing VM Types JSON
        //===========================

        List<VMType> vmTypes;
        try
        {
            vmTypes = JsonConvert.DeserializeObject<List<VMType>>(vmTypesJson);
        }
        catch
        {
            //>> Invalid JSON Response
            return new ConflictObjectResult(E.INVALID_VMTYPES_RESPONSE);
        }





        //>>  Deserialization yielded null
        if (vmTypes == null) return new NotFoundObjectResult(E.EMPTY_VMTYPES_RESPONSE);





        //>>  Returning the VM Types (FX auto serialize it again to JSON)
        return new OkObjectResult(vmTypes);

    }
}
