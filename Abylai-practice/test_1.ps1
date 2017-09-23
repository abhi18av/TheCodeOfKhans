$number = Read-Host -Prompt 'Please enter a number: '
if ($number -gt 0 -and $number -lt 14) {
    Write-Host "I have a card"
}
else {
    Write-Host "There is no such card"
}