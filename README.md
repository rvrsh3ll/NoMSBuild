# NoMSBuild
MSBuild without MSbuild.exe

## Instructions

Replace the base64 shellcode, process path, and AssemblyFile variable in buildit.csproj to suite your needs.

You may also place buildit.csproj on a remote share (smb/webdav) and modify the projectPath variable in Program.cs of NoMSBuild project to point to it.