using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using S = System.Text.StringBuilder;

namespace buhtig.Stuff
{

public class Benutzer
{
    public string Benutzer_name { get; set; }
    public string Passwort_hash { get; set; }
    public static string HashPassword(string password)
    {
        return string.Join(string.Empty, SHA1.Create().ComputeHash(Encoding.Default.GetBytes(password)).Select(x => x.ToString()));
    }
    public Benutzer(string username, string password)
    {
        Benutzer_name = username;
        Passwort_hash = HashPassword(password);
    }}

public class Kommentar
{
    string text;
    public Kommentar(Benutzer author, string text)
    {
        this.Author = author;
        this.Text = text;
    }
    public Benutzer Author { get; set; }
    public string Text
    {
        get {
            return this.text;
        }
        set {
            if (value == null||value == ""||value.Length<2) {
                throw new ArgumentException("The text must be at least 2 symbols long");
            }
            this.text = value;
        }
    }
    public override string ToString()
    {
        return new S().AppendLine(Text).AppendFormat("-- {0}", Author.Benutzer_name).AppendLine().ToString().Trim();
    }
}}