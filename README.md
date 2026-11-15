# 2D Rigid-Body Physics Engine (C# / .NET)

A deterministic 2D rigid-body physics simulation engine written from scratch in C# without external physics libraries. Designed with clean Object-Oriented Architecture, minimal garbage-collection (GC) overhead in update loops, and high numerical stability.

## Core Architecture & Project Structure
- **`Maths/Vec2.cs` (Mathematics Library):** Custom 2D vector arithmetic (`Vec2`), dot/cross products, normalization, distance calculations, and tolerance-based floating-point comparisons.
- **`Program.cs` (Simulation & Dynamics Loop):** Rigid-body state integration, time-stepping simulation loop, and collision testing routines.

## Active Development Roadmap (Upcoming Milestones)
- [ ] **Rigid-Body & Shape System:** Extract modular `RigidBody`, `AABB`, `CircleShape`, and `PolygonShape` classes into dedicated namespaces.
- [ ] **Narrow-Phase Collision Detection:** Full Separating Axis Theorem (SAT) implementation and contact manifold generation.
- [ ] **Impulse & Friction Solver:** Impulse-based linear/angular velocity resolution with configurable restitution and Coulomb friction.
- [ ] **Broad-Phase Optimization:** Implement Spatial Hashing and a Dynamic Quadtree to reduce collision checks from O(n^2) to O(n log n).
- [ ] **Positional Correction & Constraints:** Baumgarte stabilization to eliminate object sinking/jitter and distance/spring joint solvers.
- [ ] **Unit Testing & Benchmark Suite:** Automated xUnit deterministic physics tests and frame-time profiling benchmarks.

## Building & Running
Requires the **.NET SDK** (8.0+).

    dotnet build --configuration Release
    dotnet run

## License
Distributed under the MIT License. See `LICENSE` for more information.
