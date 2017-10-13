<#This script is analog of bash example from http://www.learnshell.org/en/File_Testing #>

<#see the file exists#>
$file_path = Test-Path C:\Users\qqs\Documents\TheCodeOfKhans\Abylai-practice\file_testing.ps1 
<#extracting a file name to variable#>
$filename = [System.IO.Path]::GetFileName("C:\Users\qqs\Documents\TheCodeOfKhans\Abylai-practice\file_testing.ps1")
if($file_path){
    echo "$filename exists as a file"
}

<#To check directory existence we use the same methods#>
$dir_path = Test-Path C:\Users\qqs\Documents\TheCodeOfKhans\Abylai-practice 
<#extracting a file name to variable#>
$dir_name = [System.IO.Path]::GetFileName("C:\Users\qqs\Documents\TheCodeOfKhans\Abylai-practice")
if($dir_path){
    echo "$dir_name exists as a directory"
}

<#read file permissions#>
Get-Acl $filename