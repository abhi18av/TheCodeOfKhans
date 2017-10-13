<#This script is analog of bash example from http://www.learnshell.org/en/Special_Variables #>
$MyInvocation.MyCommand.Name <#- The filename of the current script.#>
Get-Location <#Get path of the script#>
$? <# The exit status of the last command executed #>