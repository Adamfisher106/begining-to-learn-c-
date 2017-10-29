using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

interface ILog
{
    void Log(string msgToLog);
}

class ConsoleLog: ILog
{
    public void Log(string msgToPrint) //to make this an explicit implementation I would change this line to  Public boid ILog.Log(string msgToPrint)
    {
        Console.WriteLine(msgToPrint);
    }
}

class FileLog :ILog
{
    public void Log(string msgToPrint)
    {
        FileLog.AppendText(@"C:Log.txt").Write(msgToPrint);
    }
}

ILog log = new ConsoleLog();

//or

ILog log = new FileLog();