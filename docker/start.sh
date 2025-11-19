#!/bin/bash

# Weight Tracker Docker Startup Script

set -e

echo "Starting Weight Tracker Application..."

# Check if Docker is running
if ! docker info > /dev/null 2>&1; then
    echo "Docker is not running. Please start Docker and try again."
    exit 1
fi

# Function to show usage
show_usage() {
    echo "Usage: $0 [dev|prod|down|clean]"
    echo ""
    echo "Commands:"
    echo "  dev   - Start in development mode"
    echo "  prod  - Start in production mode (default)"
    echo "  down  - Stop all containers"
    echo "  clean - Stop containers and remove volumes"
    echo ""
}

# Get command or default to prod
COMMAND=${1:-prod}

case $COMMAND in
    "dev")
        echo "Starting in Development mode..."
        docker-compose -f docker-compose.dev.yml up --build -d
        ;;
    "prod")
        echo "Starting in Production mode..."
        docker-compose up --build -d
        ;;
    "down")
        echo "Stopping containers..."
        docker-compose down
        docker-compose -f docker-compose.dev.yml down
        ;;
    "clean")
        echo "Cleaning up containers and volumes..."
        docker-compose down -v
        docker-compose -f docker-compose.dev.yml down -v
        docker system prune -f
        ;;
    "help"|"-h"|"--help")
        show_usage
        exit 0
        ;;
    *)
        echo "Unknown command: $COMMAND"
        show_usage
        exit 1
        ;;
esac

if [ "$COMMAND" = "dev" ] || [ "$COMMAND" = "prod" ]; then
    echo ""
    echo "✅ Containers are starting up..."
    echo ""
    echo "Service URLs:"
    echo "   Blazor Client: http://localhost:8080"
    echo "   API: http://localhost:5271"
    echo "   API Documentation: http://localhost:5271/swagger"
    echo ""
    echo "To view container status: docker-compose ps"
    echo "To view logs: docker-compose logs -f"
    echo "To stop: ./start.sh down"
fi