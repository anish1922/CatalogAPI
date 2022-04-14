pipeline {
    agent any
   
    environment {
        DOTNET_SYSTEM_GLOBALIZATION_INVARIANT='true'
        PATH = "/var/jenkins_home/tools/io.jenkins.plugins.dotnet.DotNetSDK/dotnet:$PATH:$HOME/.dotnet/tools:$PATH:/var/jenkins_home/tools/hudson.plugins.sonar.SonarRunnerInstallation/sonar-scanner:$PATH"
        DOTNET_ROOT="/var/jenkins_home/tools/io.jenkins.plugins.dotnet.DotNetSDK/dotnet"
  }
    
    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        stage('Build') {
            steps {
               echo "helo"
            }
        }
        stage('CodeAnalysis') {
            steps {
                 
                  sh "dotnet sonarscanner begin /k:test /d:sonar.host.url=http://172.19.0.3:9000"
                  sh "dotnet build "
                  sh "dotnet sonarscanner end "
                
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
