# Dependency
This library was created by .Net 8.0

## Install
``` 
dotnet add package SY.FileService
``` 
## Usage
If you want to save file in server

``` 
string filePath = "./Files/";

string fileName = FileService.FileSaveToServer(file,filePath);
```
If you want to delete file in server
```
string path = "./Files/" + "FileName";

FileService.FileDeleteToServer(path);
```
