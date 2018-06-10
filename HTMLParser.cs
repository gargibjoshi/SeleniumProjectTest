using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;
/// <summary>
/// Summary description for HTMLParser
/// </summary>
public class HTMLParser
{
    public HtmlDocument htmlDoc = new HtmlDocument();
    public Dictionary<string, List<string>> parsedElements = new Dictionary<string, List<string>>();
    public int elementCount = 0;
    public string uiUsage, uiElement, uiAction;
    public HTMLParser()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void Parse(string filePath)
    {
        htmlDoc.Load(@"TestHTML.html");
        StoreAllReqElements("input");
        StoreAllReqElements("select");
        StoreAllReqElements("button");
        StoreAllReqElements("a");
        GenerateCode();

    }
    public void StoreAllReqElements(string selectElementType)
    {
        HtmlNode docNode = htmlDoc.DocumentNode;
        HtmlNodeCollection nodes = docNode.SelectNodes("//" + selectElementType + ""); //SelectNodes takes a XPath expression
        List<string> tempList = new List<string>();
        foreach (HtmlNode node in nodes)
        {
            tempList.Add(node.GetAttributeValue("id", "NoId"));    // Fetch id of HTML element
            tempList.Add(node.GetAttributeValue("name", "NoName"));  // Fetch parameter name (GET/POST)
            tempList.Add(node.GetAttributeValue("type", "NoType"));  // Fetch type of input element
            tempList.Add(node.XPath);
            parsedElements.Add("element" + elementCount, tempList);
            elementCount++;
        }
    }

    public void GenerateCode()
    {
        foreach (KeyValuePair<string, List<string>> entry in parsedElements)
        {
            // do something with entry.Value or entry.Key

            uiElement += GenerateUIElements(entry.Value);
            uiUsage += GenerateUIUsage(entry.Value);
            uiAction += GenerateAction(entry.Value);
        }
    }
    public string GenerateUIElements(List<string> elementList)
    {
        string elementType = elementList[2];
        string elementName = elementList[1];
        string elementId = elementList[0];
        string tempUIElement = "";
        switch (elementType)
        {
            case "text":

                tempUIElement += "[FindsBy(How = How.Id, Using = " + elementId + ")]public IWebElement txt" + elementName + " { get; set; }";
             
                break;
            case "radio":
                tempUIElement += "[FindsBy(How = How.Id, Using = " + elementId + ")]public IWebElement txt" + elementName + " { get; set; }";

                break;
            case "checkbox":
                tempUIElement += "[FindsBy(How = How.Id, Using = " + elementId + ")]public IWebElement txt" + elementName + " { get; set; }";

                break;
            case "button":
                tempUIElement += "[FindsBy(How = How.Id, Using = " + elementId + ")]public IWebElement txt" + elementName + " { get; set; }";

                break;
        }
        return tempUIElement;
    }
    public string GenerateUIUsage(List<string> elementList)
{
    string elementType = elementList[2];

    switch (elementType)
    {
        case "text":
            break;
        case "radio":
            break;
        case "checkbox":
            break;
        case "button":
            break;
    }
    return "";
}
public string GenerateAction(List<string> elementList)
{
    string elementType = elementList[2];

    switch (elementType)
    {
        case "text":
            break;
        case "radio":
            break;
        case "checkbox":
            break;
        case "button":
            break;
    }
    return "";

}
}