$parsed =  Get-Content -Raw -Path C:\Users\parth\Desktop\_json.json | ConvertFrom-Json
Write-Host $parsed.name
