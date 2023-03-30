
using System;
using System.IO;

string currentDirectory = Environment.CurrentDirectory;

string newFilePath = Path.Combine(currentDirectory, "newFile.txt");

File.Create(newFilePath);

File.WriteAllText(newFilePath, "Hello World!");

string text = File.ReadAllText(newFilePath);

File.Delete(newFilePath);

bool exists = File.Exists(newFilePath);

File.Copy(newFilePath, Path.Combine(currentDirectory, "newFileCopy.txt"));

File.Move(newFilePath, Path.Combine(currentDirectory, "newFileMoved.txt"));

DateTime creationTime = File.GetCreationTime(newFilePath);

DateTime lastWriteTime = File.GetLastWriteTime(newFilePath);

DateTime lastAccessTime = File.GetLastAccessTime(newFilePath);

File.SetCreationTime(newFilePath, DateTime.Now);

File.SetLastWriteTime(newFilePath, DateTime.Now);

File.SetLastAccessTime(newFilePath, DateTime.Now);

FileAttributes attributes = File.GetAttributes(newFilePath);

File.SetAttributes(newFilePath, FileAttributes.ReadOnly);

File.OpenRead(newFilePath);

File.OpenWrite(newFilePath);

File.Open(newFilePath, FileMode.Open);

File.OpenText(newFilePath);

File.AppendText(newFilePath);


