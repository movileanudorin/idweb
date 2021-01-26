#!groovy

pipeline {
  
  agent any
  options {
      timestamps()
  }
  
  stages{
    
          stage("Build"){
            steps {
                
		bat "\"${tool 'MSBuild'}\" BlazorApp3.sln -t:restore /p:Configuration=Release /p:Platform=\"Any CPU\""
            }
          }
  
          stage("Test"){
               steps {
                    bat "dotnet test BlazorApp3.Server.UnitTests\\BlazorApp3.Server.UnitTests.csproj"
                }
	  }

	stage('Publish'){
     		steps{
       			bat "dotnet publish BlazorApp3\\Server\\BlazorApp3.Server.csproj"
     		}
	  }
       }
	
  post {
     
	success {
            emailext body: 'Build successed', recipientProviders: [[$class: 'DevelopersRecipientProvider'], [$class: 'RequesterRecipientProvider']], subject: 'Test'
        }
	  
	failure {
            emailext body: 'Build failed', recipientProviders: [[$class: 'DevelopersRecipientProvider'], [$class: 'RequesterRecipientProvider']], subject: 'Test'
        }
    }
  
}
