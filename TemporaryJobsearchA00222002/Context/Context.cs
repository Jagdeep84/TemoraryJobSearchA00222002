using Microsoft.EntityFrameworkCore;
using TemporaryJobsearchA00222002.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemporaryJobsearchA00222002.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<SavedSearch> SavedSearches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
        
    }
}
