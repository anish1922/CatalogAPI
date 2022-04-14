pipeline {
    agent any
   
    environment {
        DOTNET_SYSTEM_GLOBALIZATION_INVARIANT='true'
        PATH = "/var/jenkins_home/tools/io.jenkins.plugins.dotnet.DotNetSDK/dotnet::$PATH"
  }
    
    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        stage('Build') {
            steps {
               sh "dotnet build ${WORKSPACE}"
            }
        }
        stage('CodeAnalysis') {
            steps {
                  withSonarQubeEnv('http://localhost:9000')
                {
                  sh "dotnet sonarscanner begin /k:test /d:sonar.login=99ad1d398b193d508ce474a286a596d2d528dd42"
                  sh "dotnet build "
                  sh "dotnet sonarscanner end /d:sonar.login=99ad1d398b193d508ce474a286a596d2d528dd42"
                }
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
