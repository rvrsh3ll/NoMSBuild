# NoMSBuild
MSBuild without MSbuild.exe. Shellcode injection using D/Invoke sample from here: https://gist.github.com/jfmaes/944991c40fb34625cf72fd33df1682c0

## Instructions

Replace the base64 shellcode, process path, and AssemblyFile variable in buildit.csproj to suite your needs.

You may also place buildit.csproj on a remote share (smb/webdav) and modify the projectPath variable in Program.cs of NoMSBuild project to point to it.