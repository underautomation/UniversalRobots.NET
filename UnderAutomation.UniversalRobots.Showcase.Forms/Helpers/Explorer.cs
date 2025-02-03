using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


public static class Explorer
{
    public static void RevealFile(string path)
    {
        Process.Start("explorer.exe", $"/select,\"{path}\"");
    }
    public static void OpenDirectory(string path)
    {
        Process.Start("explorer.exe", path);
    }

    public static void SaveFromResources(string resourceNamespace, string fileName)
    {
        using (var dlg = new SaveFileDialog())
        {
            dlg.FileName = fileName;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream($"{resourceNamespace}.{fileName}"))
                {
                    using (var file = new System.IO.FileStream(dlg.FileName, System.IO.FileMode.Create))
                    {
                        stream.CopyTo(file);
                    }
                }

                RevealFile(dlg.FileName);   
            }
        }
    }
}
