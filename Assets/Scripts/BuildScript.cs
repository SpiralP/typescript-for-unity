#if UNITY_EDITOR
using System.IO;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

class BuildScript : IPostprocessBuildWithReport {
	public int callbackOrder { get { return 0; } }
	public void OnPostprocessBuild(BuildReport report) {
		string from = Application.dataPath + "/../src/";
		string to = Path.GetDirectoryName(report.summary.outputPath) + "/DATA/StreamingAssets/src/";
		Directory.CreateDirectory(to);

		UnityEngine.Debug.Log($"Copying {from} to {to}");

		CopyDir(
			from,
			to
		);
	}

	private void CopyDir(string SourcePath, string DestinationPath) {
		//Now Create all of the directories
		foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
				SearchOption.AllDirectories))
			Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

		//Copy all the files & Replaces any files with the same name
		foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
				SearchOption.AllDirectories))
			File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);
	}
}

#endif
