pipeline {
    agent any
   
    
    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        stage('Build') {
            steps {
                sh 'dotnet build CatalogAPI.sln --configuration Release --no-restore'
            }
        }
        stage('CodeAnalysis') {
            steps {
                 echo "The build number is ${env.BUILD_NUMBER}"
                echo "You can also use \${BUILD_NUMBER} -> ${BUILD_NUMBER}" 
                  echo "You can also use \${BUILD_NUMBER} -> ${WORKSPACE}" 
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
